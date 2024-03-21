
const treeWalker = document.createTreeWalker(
    document, NodeFilter.SHOW_ELEMENT);

let node = treeWalker.nextNode();

while (node) {
    if (node instanceof HTMLParagraphElement) {
        node.style.backgroundColor = "#CCC";
    }

    console.log(node.nodeName);
    node = treeWalker.nextNode();
}