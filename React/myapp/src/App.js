import logo from './logo.svg';
import './App.css';

function App() {
  //   console.log(x)//undefined before this is only declration
  //   var x = 5;
  //  console.log(x)

  // let x = 5;
  // console.log(x)
  // x = 4;
  //  console.log(x)
  //  const x = 6;
  //  console.log(x) 

  //  const add = (a,b) => a+b;
  //  const c = add(5,4);
  //  console.log(c);

// const user = {name:"kunal",age:12};
//   user.name = "jindal";
//   const {name,age} = user;
//   console.log(user);

// let a = 1,b=2;
// [a,b] = [b,a];
// console.log(a);
// console.log(b);

// const prev = {name:'A',age:20};
// console.log(prev);
// const next = {...prev,age:21};
// next.age = 22;
// console.log(next);
// console.log(prev);
// ``

const user = {name:"kun",age:21,place:"Mangalore"};
const {name,...rest} = user;

console.log(name);
console.log(rest);

  return (
    
   <div>
    <h1>Counter</h1>
    <h2 id = 'a'>0</h2>
    <button onClick={()=>{
      const ele = document.getElementById('a');
      var cur = parseInt(ele.textContent);
      ele.textContent = cur+1;
    }}>
      Increament
    </button>

     
    <button onClick={()=>{
      const ele = document.getElementById('a');
      var cur = parseInt(ele.textContent);
      ele.textContent = cur-1;
    }}>
      Decreament 
    </button>
   </div>
  );
}

export default App;
