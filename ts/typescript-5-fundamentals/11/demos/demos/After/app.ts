import { Movie, Logger, CastMember as Actor } from "./interfaces";
import { Performer, Documentary, Favorites } from "./classes";
import * as Utility from "./functions";
import * as _ from "lodash";

let sportsDoc: Documentary = new Documentary('Baseball', 1994, 'History');
sportsDoc.printItem();