import logo from './logo.svg';
import './App.css';
import { useEffect, useState } from 'react';

function App() {
  const [pos,setPos] = useState({x:0,y:0});
  useEffect(()=>{
    const handleMouse = (event)=>{
      setPos({x:event.clientX,y:event.clientY});
    };

    window.addEventListener('mousemove',handleMouse);

    return ()=>{
      window.removeEventListener('mousemove',handleMouse);
    };
  },[]);

  return (
    <>
    <h2>Mouse Tracker</h2>
    <p>Mouse position:({pos.x},{pos.y})</p>
    </>
  );
}

export default App;
