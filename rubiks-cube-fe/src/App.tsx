import { useState } from "react";
import "./App.css";
import Cube from "./components/Cube";
import { CubeType, Direction } from "./utilities/types";
import Rotations from "./components/Rotations";
import { rotateSide } from "./service/RotationService";

function App() {
  const [cube, setCube] = useState(initialState);

  async function handleRotation(direction: Direction) {
    const newCube = await rotateSide(cube, direction);
    setCube(newCube);
  }

  return (
    <div className="">
      <h1>Rubik's Cube</h1>
      <Cube cubeProp={cube} />
      <Rotations rotate={handleRotation} />
    </div>
  );
}

export default App;

const initialState: CubeType = {
  sides: {
    front: [
      ["green", "green", "green"],
      ["green", "green", "green"],
      ["green", "green", "green"],
    ],
    top: [
      ["white", "white", "white"],
      ["white", "white", "white"],
      ["white", "white", "white"],
    ],
    left: [
      ["orange", "orange", "orange"],
      ["orange", "orange", "orange"],
      ["orange", "orange", "orange"],
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
    down: [
      ["yellow", "yellow", "yellow"],
      ["yellow", "yellow", "yellow"],
      ["yellow", "yellow", "yellow"],
    ],
  },
};
