import { getGridClasses } from "../utilities/styleUtils";
import { SideFace, SideType } from "../utilities/types";
import Side from "./Side";

export type CubeProps = {
  sides: Record<SideFace, SideType>;
};

const Cube = ({ sides }: CubeProps) => {
  return (
    <div className="grid grid-cols-4 gap-1">
      {Object.entries(sides).map(([face, colours]) => {
        // Ensure that the face is one of the allowed values.
        if (!["top", "left", "front", "right", "back", "down"].includes(face)) {
          return null;
        }
        return (
          <div key={face} className={getGridClasses(face as SideFace)}>
            <Side face={face as SideFace} colours={colours} />
          </div>
        );
      })}
    </div>
  );
};

export default Cube;
