import React from 'react';

function ListOfIndianPlayers({ IndianPlayers }) {
  return (
    <div>
      {IndianPlayers.map((player) => (
        <li key={player}>Mr. {player}</li>
      ))}
    </div>
  );
}

export default ListOfIndianPlayers;