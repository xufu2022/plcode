
const itemInput = document
    .querySelector<HTMLInputElement>("#itemInput");
const addButton = document.querySelector("#addButton");
const list = document.querySelector("#list");

itemInput.addEventListener("keyup", (e) => {
    if (e.key === "Enter") {
        addItem();
    }
});

addButton.addEventListener("click", addItem);

function addItem() {
    const listItem = document.createElement("li");
    const textNode =
        document.createTextNode(itemInput.value);
    const removeButton =
        document.createElement("button");
    removeButton.textContent = "Remove";
    removeButton.style.margin = "2px 5px";
    removeButton.addEventListener("click", removeItem);

    listItem.append(textNode);
    listItem.append(removeButton);

    list.prepend(listItem);

    itemInput.value = "";
    itemInput.focus();
}

function removeItem(e: Event) {
    const removeButton = e.target as HTMLButtonElement;
    const listItem = removeButton.parentElement;
    listItem.remove();
}