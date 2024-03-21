import { CoffeesComponent } from "./components/coffeesComponent";
import { ShopsComponent } from "./components/shopsComponent";

const output = document.querySelector("#output");
const coffeesButton = document
    .querySelector("#coffeesButton");
const shopsButton = document
    .querySelector("#shopsButton");

coffeesButton.addEventListener("click", () => {
    output.replaceChildren(
        new CoffeesComponent().render());
});

shopsButton.addEventListener("click", () => {
    output.replaceChildren(
        new ShopsComponent().render());
});

