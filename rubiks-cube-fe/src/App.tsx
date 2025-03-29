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
  sides: [
    {
      face: "front",
      colours: [
        ["green", "green", "green"],
        ["green", "green", "green"],
        ["green", "green", "green"],
      ],
    },
    {
      face: "top",
      colours: [
        ["white", "white", "white"],
        ["white", "white", "white"],
        ["white", "white", "white"],
      ],
    },
    {
      face: "left",
      colours: [
        ["orange", "orange", "orange"],
        ["orange", "orange", "orange"],
        ["orange", "orange", "orange"],
      ],
    },
    {
      face: "right",
      colours: [
        ["red", "red", "red"],
        ["red", "red", "red"],
        ["red", "red", "red"],
      ],
    },
    {
      face: "back",
      colours: [
        ["blue", "blue", "blue"],
        ["blue", "blue", "blue"],
        ["blue", "blue", "blue"],
      ],
    },
    {
      face: "bottom",
      colours: [
        ["yellow", "yellow", "yellow"],
        ["yellow", "yellow", "yellow"],
        ["yellow", "yellow", "yellow"],
      ],
    },
  ],
};
