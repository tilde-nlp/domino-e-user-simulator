export const configuration: Configuration = {
  pageUrl: process.env.PLAYWRIGHT_PAGE_URL, // For domino project was used https://va.tilde.com/api/prodk8sbotdomin0/media/staging/uas.html
};

export interface Configuration {
  pageUrl: string | URL | undefined;
}
