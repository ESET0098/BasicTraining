
import './App.css';
import { useState } from 'react';


function App() {

  const [count,setCount] = useState(0);
function Btn({label,onClick}){
  return <button onClick={onClick}>{label}</button>
}

function incrment(){
  setCount(count+1);
  console.log("Incremented");
}
function decreament(){
  setCount(count-1);
  console.log("Decremented");
}
  return (
   <>
    <h1>Counter App</h1>
    <h2>Count: {count}</h2>
    <Btn label="Increment" onClick={incrment}/>
    <Btn label="Decrement" onClick={decreament}/>
   </>
  );
}

export default App;
