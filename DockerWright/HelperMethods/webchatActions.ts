import { Page } from "playwright";
import { expect } from "playwright/test";

export const sendMessageToWebchat = async (page: Page, message: string) => {
  await page.locator(".webchat__send-box-text-box__input").fill(message);
  await page.locator(".webchat__send-button").click();
};

export const getMessageFromWebchat = async (page: Page, message: string) => {
  const proceedMessage = page.locator(".webchat__bubble__content p", {
    hasText: message,
  });

  await page.waitForSelector(".webchat__bubble__content p", {
    state: "attached", // Ensures the element is in the DOM
  });

  await proceedMessage.waitFor({ state: "visible" });

  const allMessagesTexts = await page
    .locator(".webchat__bubble__content p")
    .allTextContents();

  if (allMessagesTexts.includes("Context does not provide")) {
    throw new Error("Context does not provide");
  }
  await expect(proceedMessage).toBeVisible();
};

export const waitForLoadingEnds = async (page: Page) => {
  await page.waitForSelector(".webchat__typingIndicator", {
    state: "hidden",
    timeout: 15000, // Increase timeout in case response is slow
  });
};
