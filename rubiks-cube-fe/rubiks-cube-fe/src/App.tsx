import "./App.css";
import Cube, { CubeProps } from "./components/Cube";
import { Colour, SideLabel } from "./utilities/enums";

function App() {
  const sides: CubeProps["sides"] = [
    {
      label: SideLabel.Front,
      colours: [
        [Colour.Green, Colour.Green, Colour.Green],
        [Colour.Green, Colour.Green, Colour.Green],
        [Colour.Green, Colour.Green, Colour.Green],
      ],
    },
    {
      label: SideLabel.Top,
      colours: [
        [Colour.White, Colour.White, Colour.White],
        [Colour.White, Colour.White, Colour.White],
        [Colour.White, Colour.White, Colour.White],
      ],
    },
    {
      label: SideLabel.Left,
      colours: [
        [Colour.Orange, Colour.Orange, Colour.Orange],
        [Colour.Orange, Colour.Orange, Colour.Orange],
        [Colour.Orange, Colour.Orange, Colour.Orange],
      ],
    },
    {
      label: SideLabel.Right,
      colours: [
        [Colour.Red, Colour.Red, Colour.Red],
        [Colour.Red, Colour.Red, Colour.Red],
        [Colour.Red, Colour.Red, Colour.Red],
      ],
    },
    {
      label: SideLabel.Back,
      colours: [
        [Colour.Blue, Colour.Blue, Colour.Blue],
        [Colour.Blue, Colour.Blue, Colour.Blue],
        [Colour.Blue, Colour.Blue, Colour.Blue],
      ],
    },
    {
      label: SideLabel.Bottom,
      colours: [
        [Colour.Yellow, Colour.Yellow, Colour.Yellow],
        [Colour.Yellow, Colour.Yellow, Colour.Yellow],
        [Colour.Yellow, Colour.Yellow, Colour.Yellow],
      ],
    },
  ];

  return (
    <div>
      <h1>Rubik's Cube</h1>
      <Cube sides={sides} />
    </div>
  );
}

export default App;
