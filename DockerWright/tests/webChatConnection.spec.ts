import { test, expect } from "@playwright/test";
import { waitForWebChatConnection } from "../HelperMethods/waitForWebChatConnection";
import { chatUrl, domain } from "../HelperMethods/constantsForWebchatTest";

test("should connect to webchat", async ({ page }) => {
  await page.goto(chatUrl, { waitUntil: "networkidle" }); // Wait for full page load

  const isConnected = await waitForWebChatConnection(page, domain);
  expect(isConnected).toBe(true);
});
