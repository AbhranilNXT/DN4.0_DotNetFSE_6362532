import React from 'react';

function SyntheticEvent() {
  const handleClick = (e) => {
    console.log(e);
    alert('I was clicked');
  };

  return (
    <div>
      <h2>Synthetic Event Example</h2>
      <button onClick={handleClick}>Click Me (OnPress)</button>
    </div>
  );
}

export default SyntheticEvent;