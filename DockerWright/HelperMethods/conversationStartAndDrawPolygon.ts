import { Page } from "playwright";
import { expect } from "playwright/test";
import {
  getMessageFromWebchat,
  sendMessageToWebchat,
  waitForLoadingEnds,
} from "./webchatActions";

export const conversationStartAndDrawPolygon = async (
  page: Page,
  place: string,
  polygonCoordinates: { x: number; y: number }[]
) => {
  await page.locator("#webchat", { hasText: "Please name the place" });

  await sendMessageToWebchat(page, place);

  await waitForLoadingEnds(page);

  await getMessageFromWebchat(page, "use the map to specify the region");

  await page.waitForFunction(() => document.querySelector(".mapboxgl-canvas"));

  const mapLocator = page.getByLabel("Map", { exact: true });
  await expect(mapLocator).toBeVisible();

  // wait 2 seconds after map is visible to be sure that map is generated
  await page.waitForTimeout(2000);

  await page.getByRole("button", { name: "Polygon tool (p)" }).click();
  await page.waitForTimeout(300); // Delay between clicks

  for (let i = 0; i < polygonCoordinates.length - 1; i++) {
    await page.getByLabel("Map", { exact: true }).click({
      position: {
        x: polygonCoordinates[i].x,
        y: polygonCoordinates[i].y,
      },
    });
    await page.waitForTimeout(200); // Delay between clicks
  }
  await page.getByLabel("Map", { exact: true }).dblclick({
    position: {
      x: polygonCoordinates[polygonCoordinates.length - 1].x,
      y: polygonCoordinates[polygonCoordinates.length - 1].y,
    },
  });

  await waitForLoadingEnds(page);
};
