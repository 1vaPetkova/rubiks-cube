import { useState } from "react";
import "./App.css";
import Cube from "./components/Cube";
import { CubeType, Direction } from "./utilities/types";
import Rotations from "./components/Rotations";
import { rotateSide } from "./service/RotationService";
import ResetButton from "./components/ResetButton";

function App() {
  const [cube, setCube] = useState(initialState);

  async function handleRotation(direction: Direction) {
    const newCube = await rotateSide(cube, direction);
    setCube(newCube);
  }

  function handleReset() {
    setCube(initialState);
  }
  return (
    <div className="pl-10 mt-10">
      <h1 className="text-3xl font-bold font-sans text-indigo-800">
        Rubik's Cube
      </h1>
      <div>
        <Cube sides={cube.sides} />
        <Rotations rotate={handleRotation} />
        <ResetButton reset={handleReset} />
      </div>
    </div>
  );
}

export default App;

const initialState: CubeType = {
  sides: {
    left: [
      ["orange", "orange", "orange"],
      ["orange", "orange", "orange"],
      ["orange", "orange", "orange"],
    ],
    front: [
      ["green", "green", "green"],
      ["green", "green", "green"],
      ["green", "green", "green"],
    ],
    right: [
      ["red", "red", "red"],
      ["red", "red", "red"],
      ["red", "red", "red"],
    ],
    back: [
      ["blue", "blue", "blue"],
      ["blue", "blue", "blue"],
      ["blue", "blue", "blue"],
    ],
    top: [
      ["white", "white", "white"],
      ["white", "white", "white"],
      ["white", "white", "white"],
    ],
    down: [
      ["yellow", "yellow", "yellow"],
      ["yellow", "yellow", "yellow"],
      ["yellow", "yellow", "yellow"],
    ],
  },
};
