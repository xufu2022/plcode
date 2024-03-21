
const elements =
    document.getElementsByClassName("list-item");

let count = 1;
for (const element of elements) {
    if (element instanceof HTMLElement) {
        element.style.backgroundColor = "#CCC";
        element.textContent =
            `${count++}. ${element.textContent}`;
    }
}
