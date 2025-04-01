interface ResetButtonProps {
  reset: () => void;
}

const ResetButton = ({ reset }: ResetButtonProps) => {
  return (
    <button
      className="flex p-2 bg-indigo-600 hover:bg-indigo-800 rounded-lg"
      onClick={reset}
    >
      Reset
    </button>
  );
};

export default ResetButton;
