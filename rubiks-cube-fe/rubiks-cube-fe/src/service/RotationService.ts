import { CubeType, Direction, SideType } from "../utilities/types";

export const rotateSide = async (
  cube: CubeType,
  direction: Direction
): Promise<CubeType> => {
  const newSides = cube.sides.toReversed() as [
    SideType,
    SideType,
    SideType,
    SideType,
    SideType,
    SideType
  ];
  const payload = { cube, direction };

  const requestOptions: RequestInit = {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify(payload),
  };
  await fetch("https://reqres.in/api/posts", requestOptions).then(
    async (response) => console.log(await response.json())
  );

  const newCube = { sides: newSides };
  return newCube;
};

interface RequestPayload {
  method: string;
  url: string;
  headers: {
    "Content-Type": string;
  };
  body: string;
}
