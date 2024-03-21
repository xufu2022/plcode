import { CastMember } from "./interfaces";

export class Performer implements CastMember {

  name: string = "";
  email: string = "";
  role: string = "";

  rehearse(sceneNumber: number): void {
    console.log(`${this.name} is rehearsing scene number ${sceneNumber}.`);
  }

}

abstract class Video {

  private _producer: string = '';
  static medium: string = 'Audio/Visual';

  get producer(): string {
    return this._producer.toUpperCase();
  }

  set producer(newProducer: string) {
    this._producer = newProducer;
  }

  constructor(public title: string, protected year: number) {
    console.log('Creating a new Video...');
  }

  printItem(): void {
    console.log(`${this.title} was released in ${this.year}.`);
    console.log(`Medium: ${Video.medium}`);
  }

  abstract printCredits(): void;
}

export class Documentary extends Video {

  constructor(newTitle: string, newYear: number, public subject: string) {
    super(newTitle, newYear);
  }

  printItem(): void {
    super.printItem();
    console.log(`Subject: ${this.subject} (${this.year})`);
  }

  printCredits(): void {
    console.log(`Producer: ${this.producer}`);
  }
}

export let Musical = class extends Video {
  printCredits(): void {
    console.log(`Musical credits: ${this.producer}`);
  }
}

export class Course extends class { title: string = ''; } {
  subject: string = '';
}
