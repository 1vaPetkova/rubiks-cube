import { CubeType } from "../utilities/types";
import Side from "./Side";

export type CubeProps = {
  cubeProp: CubeType;
};

const Cube = ({ cubeProp }: CubeProps) => {
  return (
    <div className="flex gap-2">
      {cubeProp.sides.map((side, index) => (
        <div key={index} className="flex">
          <Side face={side.face} colours={side.colours} />
        </div>
      ))}
    </div>
  );
};

export default Cube;
