import { CubeType, Direction } from "../utilities/types";

export const rotateSide = async (
  cube: CubeType,
  direction: Direction
): Promise<CubeType> => {
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

  console.log("result", result);
  return result;
};
