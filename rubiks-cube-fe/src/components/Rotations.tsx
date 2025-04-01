import { Direction, DirectionsArray } from "../utilities/types";
import RotateButton from "./Button";

interface RotationsProps {
  rotate: (direction: Direction) => void;
}

const Rotations = ({ rotate }: RotationsProps) => {
  return (
    <div className="flex items-center justify-center gap-2 p-10">
      {DirectionsArray.map((direction, index) => (
        <RotateButton key={index} dir={direction} rotate={rotate} />
      ))}
    </div>
  );
};

export default Rotations;
