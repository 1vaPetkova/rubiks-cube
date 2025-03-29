import { twMerge } from "tailwind-merge";

import { Colour } from "../utilities/enums";

// Define the props interface
interface TileProps {
  colour: Colour;
}

// Create the component using React.FC (functional component)
const Tile = ({ colour }: TileProps) => {
  const twColour = ParseColour(colour);
  return (
    <div className={twMerge(twColour, "w-10 h-10 border-2 border-black")}></div>
  );
};

export default Tile;

function ParseColour(colour: Colour) {
  switch (colour) {
    case Colour.White:
      return "bg-white";
    case Colour.Yellow:
      return "bg-yellow-500";
    case Colour.Blue:
      return "bg-blue-500";
    case Colour.Green:
      return "bg-green-500";
    case Colour.Red:
      return "bg-red-500";
    case Colour.Orange:
      return "bg-orange-500";
  }
}
