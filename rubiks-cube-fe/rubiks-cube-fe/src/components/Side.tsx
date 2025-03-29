import { Colour, SideFace } from "../utilities/types";
import Tile from "./Tile";

export interface SideProps {
  face: SideFace;
  colours: [
    [Colour, Colour, Colour],
    [Colour, Colour, Colour],
    [Colour, Colour, Colour]
  ];
}

const Side = ({ face: type, colours }: SideProps) => {
  return (
    <div>
      <div className="underline">{type}</div>
      {colours.map((line, lineIndex) => (
        <div key={lineIndex} className="flex">
          {line.map((tileColour, tileIndex) => (
            <Tile key={`${lineIndex}_${tileIndex}`} colour={tileColour} />
          ))}
        </div>
      ))}
    </div>
  );
};

export default Side;
