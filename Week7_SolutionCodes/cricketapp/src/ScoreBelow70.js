import React from 'react';

function ScoreBelow70({ players }) {
  const players70 = [];

  players.map((item) => {
    if (item.score <= 70) {
      players70.push(item);
    }
    return null;
  });

  return (
    <div>
      {players70.map((item) => (
        <li key={item.name}>Mr. {item.name}</li>
      ))}
    </div>
  );
}

export default ScoreBelow70;