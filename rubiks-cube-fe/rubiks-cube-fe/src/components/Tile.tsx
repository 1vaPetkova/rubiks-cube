import { twMerge } from "tailwind-merge";

import { Colour } from "../utilities/types";

interface TileProps {
  colour: Colour;
}

const Tile = ({ colour }: TileProps) => {
  const twColour = ParseColour(colour);
  return (
    <div className={twMerge(twColour, "w-10 h-10 border-2 border-black")}></div>
  );
};

export default Tile;

function ParseColour(colour: Colour) {
  switch (colour) {
    case "white":
      return "bg-white";
    case "yellow":
      return "bg-yellow-500";
    case "blue":
      return "bg-blue-500";
    case "green":
      return "bg-green-500";
    case "red":
      return "bg-red-500";
    case "orange":
      return "bg-orange-500";
  }
}
