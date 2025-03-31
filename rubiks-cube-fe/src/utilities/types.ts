export type SideFace = "front" | "back" | "left" | "right" | "top" | "down";

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

// export type SideType = {
//   face: SideFace;
//   colours: [
//     [Colour, Colour, Colour],
//     [Colour, Colour, Colour],
//     [Colour, Colour, Colour]
//   ];
// };
export type SideType = [
  [Colour, Colour, Colour],
  [Colour, Colour, Colour],
  [Colour, Colour, Colour]
];

export type CubeType = {
  // sides: [SideType, SideType, SideType, SideType, SideType, SideType];
  sides: Record<SideFace, SideType>;
};

const cubeS: CubeType = {
  sides: {
    front: [
      ["red", "red", "red"],
      ["red", "red", "red"],
      ["red", "red", "red"],
    ],
    back: [
      ["orange", "orange", "orange"],
      ["orange", "orange", "orange"],
      ["orange", "orange", "orange"],
    ],
    left: [
      ["blue", "blue", "blue"],
      ["blue", "blue", "blue"],
      ["blue", "blue", "blue"],
    ],
    right: [
      ["green", "green", "green"],
      ["green", "green", "green"],
      ["green", "green", "green"],
    ],
    top: [
      ["white", "white", "white"],
      ["white", "white", "white"],
      ["white", "white", "white"],
    ],
    down: [
      ["yellow", "yellow", "yellow"],
      ["yellow", "yellow", "yellow"],
      ["yellow", "yellow", "yellow"],
    ],
  },
};
