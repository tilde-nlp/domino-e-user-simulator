import { test, expect } from "@playwright/test";
import { waitForWebChatConnection } from "../HelperMethods/waitForWebChatConnection";
import { chatUrl, domain } from "../HelperMethods/constantsForWebchatTest";
import {
  getMessageFromWebchat,
  sendMessageToWebchat,
} from "../HelperMethods/webchatActions";

test("should show message if town name is incorrect", async ({ page }) => {
  await page.goto(chatUrl, { waitUntil: "networkidle" }); // Wait for full page load

  const isConnected = await waitForWebChatConnection(page, domain);
  expect(isConnected).toBe(true);

  await sendMessageToWebchat(page, "rigs");
  await getMessageFromWebchat(
    page,
    "I can’t find such a place. Let’s try again"
  );
});
