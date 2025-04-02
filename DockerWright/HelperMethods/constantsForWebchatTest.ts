import { configuration } from "./../configuration";
export const place = "Riga";
export const polygonCoordinates = [
  {
    x: 96,
    y: 230,
  },
  {
    x: 269,
    y: 230,
  },
  {
    x: 269,
    y: 374,
  },
  {
    x: 96,
    y: 374,
  },
];

export const domain = new URL(configuration.pageUrl as URL).origin;
export const chatUrl = configuration.pageUrl;
