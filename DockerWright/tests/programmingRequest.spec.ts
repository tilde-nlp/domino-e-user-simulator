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
} from "./../HelperMethods/constantsForWebchatTest";

test("should hold a conversation about programming request", async ({
  page,
}) => {
  test.setTimeout(65000);

  await page.goto(chatUrl, { waitUntil: "networkidle" }); // Wait for full page load

  const isConnected = await waitForWebChatConnection(page, domain);
  expect(isConnected).toBe(true);

  await conversationStartAndDrawPolygon(page, place, polygonCoordinates);

  const buildRequestButton = page.locator("button div", {
    hasText: "Build a new Programming Request",
  });
  await buildRequestButton.waitFor({ state: "visible" });
  await expect(buildRequestButton).toBeVisible();
  await buildRequestButton.click();

  await waitForLoadingEnds(page);

  await getMessageFromWebchat(page, "Let’s proceed with this region?");

  const yesButton = page.locator("button.webchat__suggested-action", {
    hasText: "Yes",
  });
  await expect(yesButton).toBeVisible();
  await yesButton.click();

  await waitForLoadingEnds(page);

  const sentinelOption = page.getByLabel("SENTINEL-2");
  await expect(sentinelOption).toBeVisible();
  await sentinelOption.click();

  await getMessageFromWebchat(
    page,
    "Please enter the validity date for your request in the format yyyy-mm-dd"
  );

  await sendMessageToWebchat(page, "what does validity date means?");

  await getMessageFromWebchat(page, "validity date refers");

  await sendMessageToWebchat(page, "2025-03-29");

  await getMessageFromWebchat(page, "Status: CREATED");
});
