
const elements =
    document.querySelectorAll<HTMLElement>(
        "#coffees p");

for (const element of elements) {
    element.style.backgroundColor = "#CCC";
}
