
const elements = document.getElementsByTagName("p");

let count = 1;
for (const element of elements) {
    element.style.backgroundColor = "#CCC";    
    element.textContent =
       `${count++}. ${element.textContent}`;
}
