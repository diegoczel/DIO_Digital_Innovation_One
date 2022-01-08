
function addTodo() {
  let nodeDiv = document.createElement("div");
  let nodeCheck = document.createElement("input");
  let nodeSpan = document.createElement("span");

  nodeCheck.type = "checkbox";

  let nodeInput = document.getElementById('input-add-todo');
  //console.log(nodeInput.innerText);
  //console.log(nodeInput.textContent);
  //console.log(nodeInput.TEXT_NODE);
  console.log(nodeInput.value)
  //nodeInput.innerHTML = "teste";
  //console.log(nodeInput.innerText);
  //console.log(nodeInput.textContent);
  nodeSpan.innerHTML = nodeInput.value;

  nodeCheck.checked = true;
  console.log(nodeCheck.checked);

  nodeDiv.appendChild(nodeCheck);
  nodeDiv.appendChild(nodeSpan);

  document.getElementById('container2').appendChild(nodeDiv);

  nodeInput.value = "";
}

function controlDeco() {

}