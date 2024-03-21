
const output = document.querySelector("#output");
const coffeesButton = document
    .querySelector("#coffeesButton");
const shopsButton = document
    .querySelector("#shopsButton");

coffeesButton.addEventListener("click", () => {
    output.innerHTML = "<div><p>Cappuccino</p>"
        + "<p>Espresso</p><p>Mocha</p></div>";
});

shopsButton.addEventListener("click", () => {
    output.innerHTML = "<div><p>Frankfurt</p>"
        + "<p>Zurich</p></div>";
});

