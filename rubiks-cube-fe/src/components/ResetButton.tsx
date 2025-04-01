interface ResetButtonProps {
  reset: () => void;
}

const ResetButton = ({ reset }: ResetButtonProps) => {
  return (
    <button
      className="flex p-2 bg-green-500 hover:bg-green-800 rounded-lg"
      onClick={reset}
    >
      Reset
    </button>
  );
};

export default ResetButton;
