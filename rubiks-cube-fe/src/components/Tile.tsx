import { twMerge } from "tailwind-merge";

import { Colour } from "../utilities/types";
import { parseColour } from "../utilities/styleUtils";

interface TileProps {
  colour: Colour;
}

const Tile = ({ colour }: TileProps) => {
  const twColour = parseColour(colour);
  return (
    <div className={twMerge(twColour, "w-10 h-10 border-1 border-black")}></div>
  );
};

export default Tile;
