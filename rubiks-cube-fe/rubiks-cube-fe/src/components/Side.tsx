import { Colour, SideLabel } from "../utilities/enums";
import Tile from "./Tile";

export interface SideProps {
  label: SideLabel;
  colours: [
    [Colour, Colour, Colour],
    [Colour, Colour, Colour],
    [Colour, Colour, Colour]
  ];
}

const Side = ({ label, colours }: SideProps) => {
  return (
    <div className="">
      <div className="underline">{label}</div>
      {colours.map((line) => (
        <div className="flex">
          {line.map((tileColour) => (
            <Tile colour={tileColour} />
          ))}
        </div>
      ))}
    </div>
  );
};

export default Side;
