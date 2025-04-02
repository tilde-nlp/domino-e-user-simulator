import test, { expect } from "playwright/test";
import { conversationStartAndDrawPolygon } from "../HelperMethods/conversationStartAndDrawPolygon";
import { waitForWebChatConnection } from "../HelperMethods/waitForWebChatConnection";
import {
  getMessageFromWebchat,
  sendMessageToWebchat,
  waitForLoadingEnds,
} from "../HelperMethods/webchatActions";
import {
  chatUrl,
  domain,
  place,
  polygonCoordinates,
} from "../HelperMethods/constantsForWebchatTest";

test("should hold a conversation about product catalogue", async ({ page }) => {
  test.setTimeout(65000);

  await page.goto(chatUrl, { waitUntil: "networkidle" }); // Wait for full page load

  const isConnected = await waitForWebChatConnection(page, domain);
  expect(isConnected).toBe(true);

  await conversationStartAndDrawPolygon(page, place, polygonCoordinates);

  const searchProductCatalogueButton = page.locator("button div", {
    hasText: "Search the Product Catalogue",
  });
  await searchProductCatalogueButton.waitFor({ state: "visible" });
  await expect(searchProductCatalogueButton).toBeVisible();
  await searchProductCatalogueButton.click();

  await waitForLoadingEnds(page);

  await getMessageFromWebchat(page, "Let’s proceed with this region?");

  const yesButton = page.locator("button.webchat__suggested-action", {
    hasText: "Yes",
  });
  await expect(yesButton).toBeVisible();
  await yesButton.click();

  await waitForLoadingEnds(page);

  const sentinelOption = page.locator("button div", {
    hasText: "SENTINEL-2",
  });
  await expect(sentinelOption).toBeVisible();
  await sentinelOption.click();

  await getMessageFromWebchat(
    page,
    "Please specify the date in the format yyyy-mm-dd"
  );

  await sendMessageToWebchat(page, "2018-03-29");

  await getMessageFromWebchat(
    page,
    "Select an item to view the image, details, and obtain the product"
  );

  const item1Button = page.locator("button div", {
    hasText: "Item 1",
  });
  await expect(item1Button).toBeVisible();
  await item1Button.click();

  const quicklookImages = page.locator('img[alt="Quicklook Image"]');
  await quicklookImages.first().waitFor({ state: "visible" });

  const imageSources = await quicklookImages.evaluateAll((imgs) =>
    imgs.map((img) => img.getAttribute("src"))
  );

  expect(imageSources.length).toBeGreaterThan(0);
  imageSources.forEach((src) => {
    expect(src).not.toBeNull();
    expect(src).not.toBe("");
  });

  const obtainProductButton = page.getByLabel("Obtain the product");
  await obtainProductButton.scrollIntoViewIfNeeded();
  await expect(obtainProductButton).toBeVisible();
});
