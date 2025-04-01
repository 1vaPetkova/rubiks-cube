import { Colour, SideFace } from "./types";

export function parseColour(colour: Colour) {
  switch (colour) {
    case "white":
      return "bg-white";
    case "yellow":
      return "bg-yellow-400";
    case "blue":
      return "bg-blue-500";
    case "green":
      return "bg-green-500";
    case "red":
      return "bg-red-500";
    case "orange":
      return "bg-orange-400";
  }
}

export function getGridClasses(face: SideFace): string {
  switch (face) {
    case "top":
      return "col-start-2 col-span-2 row-start-1";
    case "left":
      return "col-start-1 row-start-2";
    case "front":
      return "col-start-2 row-start-2";
    case "right":
      return "col-start-3 row-start-2";
    case "back":
      return "col-start-4 row-start-2";
    case "down":
      return "col-start-2 col-span-2 row-start-3";
    default:
      return "";
  }
}
