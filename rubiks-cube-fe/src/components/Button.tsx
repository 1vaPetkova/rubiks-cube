import { Direction } from "../utilities/types";

interface ButtonProps {
  dir: Direction;
  rotate: (direction: Direction) => void;
}

const Button = ({ dir, rotate }: ButtonProps) => {
  function handleRotation() {
    rotate(dir);
  }

  return (
    <button
      className="w-10 h-10 bg-amber-400 border-amber-600 hover:bg-amber-600 rounded-lg"
      onClick={handleRotation}
    >
      {dir}
    </button>
  );
};

export default Button;
