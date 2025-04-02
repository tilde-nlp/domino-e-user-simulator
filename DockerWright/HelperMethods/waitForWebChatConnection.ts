import { Page } from "playwright";

export async function waitForWebChatConnection(
  page: Page,
  domain: string
): Promise<boolean> {
  await page.waitForSelector(".webchat__basic-transcript__activity", {
    state: "visible",
    timeout: 10000,
  });

  // Wait for the conversation to be established
  const conversationResponse = await page.waitForResponse(
    (response) =>
      response.url().includes(domain) &&
      response.url().includes("conversations")
  );

   // Ensure response is JSON before calling .json()
   let conversationId;
   try {
     conversationId = (await conversationResponse.json()).conversationId;
   } catch (error) {
     console.error("Failed to parse JSON response from:", conversationResponse.url(), "Status:", conversationResponse.status());
     return false;
   }

  // Wait for activity response linked to conversation
  const response = await page.waitForResponse(
    (response) =>
      response.url().includes(domain) &&
      response.url().includes(conversationId) &&
      response.url().includes("activities")
  );
  return response.status() === 200 || response.status() === 304;
}
