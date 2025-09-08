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

// const user = {name:"kun",age:21,place:"Mangalore"};
// const {name,...rest} = user;

// console.log(name);
// console.log(rest);

// const name = "kunal";
// const msg = `Hello ${name}`;
// const msg = `Hi
//             Hello `
// console.log(msg);

// const name = 'A';
// const age = 20;
// const preson = {name,age};
// console.log(preson);

// const utlis = {
//   greet(){
//     return `Hello ${name}`;
//   }
// }

// console.log(utlis.greet());


const items = [1,2,3,4,5];
const list = items.map((it,idx)=><li key = {idx}>{it}</li>);
const double = items.map(it=>it*2);
console.log(double);
console.log(list);

const even = [1,2,3,4].filter(n=>n%2===0).map(n=>n*2);
console.log(even);

const maxi = [1,2,3,4].reduce((acc,v)=>(v>acc?v:acc),0);
console.log(maxi);


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
