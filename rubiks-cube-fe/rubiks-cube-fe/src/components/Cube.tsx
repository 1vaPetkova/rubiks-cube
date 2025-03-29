import Side, { SideProps } from "./Side";

export interface CubeProps {
  sides: [SideProps, SideProps, SideProps, SideProps, SideProps, SideProps];
}

const Cube = ({ sides }: CubeProps) => {
  return (
    <div className="flex gap-2">
      {sides.map((side) => (
        <div className="flex">
          <Side label={side.label} colours={side.colours} />
        </div>
      ))}
    </div>
  );
};

export default Cube;
