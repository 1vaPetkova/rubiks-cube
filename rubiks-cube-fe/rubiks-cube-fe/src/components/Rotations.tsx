import { Direction, DirectionsArray } from "../utilities/types";
import Button from "./Button";

interface RotationsProps {
  rotate: (direction: Direction) => void;
}

const Rotations = ({ rotate }: RotationsProps) => {
  return (
    <div className="flex gap-2 p-10">
      {DirectionsArray.map((direction, index) => (
        <Button key={index} dir={direction} rotate={rotate} />
      ))}
    </div>
  );
};

export default Rotations;
