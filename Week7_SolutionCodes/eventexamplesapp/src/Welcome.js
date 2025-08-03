import React from 'react';

function Welcome() {
  const handleClick = (message) => {
    alert(message);
  };

  return (
    <div>
      <h2>Argument Passing Example</h2>
      <button onClick={() => handleClick('Welcome to the event examples app!')}>
        Say Welcome
      </button>
    </div>
  );
}

export default Welcome;