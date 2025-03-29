import { CubeType, Direction } from "../utilities/types";

export const rotateSide = async (
  cube: CubeType,
  direction: Direction
): Promise<CubeType> => {
  // const newSides = cube.sides.toReversed() as [
  //   SideType,
  //   SideType,
  //   SideType,
  //   SideType,
  //   SideType,
  //   SideType
  // ];
  const payload = { cube, direction };

  const requestOptions: RequestInit = {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify(payload),
  };
  const result = await fetch(
    "http://localhost:5176/cube/rotate",
    requestOptions
  ).then((response) => response.json());

  return result;
};

interface RequestPayload {
  method: string;
  url: string;
  headers: {
    "Content-Type": string;
  };
  body: string;
}
