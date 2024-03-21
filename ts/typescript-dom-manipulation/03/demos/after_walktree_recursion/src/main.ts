
walkNode(document);

function walkNode(node: Node) {
    if (node.nodeType === Node.ELEMENT_NODE) {
        console.log(node.nodeName);
    }

    if (node.hasChildNodes) {
        for (const childNode of node.childNodes) {
            walkNode(childNode);
        }
    }
}