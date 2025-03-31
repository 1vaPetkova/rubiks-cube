import { SideFace, SideType } from "../utilities/types";
import Side from "./Side";

export type CubeProps = {
  sides: Record<SideFace, SideType>;
};

const Cube = ({ sides }: CubeProps) => {
  return (
    <div className="flex gap-2">
      {Object.entries(sides).map(([face, colours], index) => (
        <div key={index} className="flex">
          <Side face={face as SideFace} colours={colours} />
        </div>
      ))}
    </div>
  );
};

export default Cube;
