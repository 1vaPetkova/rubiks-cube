export type SideFace = "front" | "back" | "left" | "right" | "top" | "bottom";

export type Colour = "white" | "yellow" | "blue" | "green" | "red" | "orange";

export const DirectionsArray = [
  "F",
  "F'",
  "R",
  "R'",
  "U",
  "U'",
  "B",
  "B'",
  "L",
  "L'",
  "D",
  "D'",
] as const;

export type Direction = (typeof DirectionsArray)[number];

export type SideType = {
  face: SideFace;
  colours: [
    [Colour, Colour, Colour],
    [Colour, Colour, Colour],
    [Colour, Colour, Colour]
  ];
};

export type CubeType = {
  sides: [SideType, SideType, SideType, SideType, SideType, SideType];
};
