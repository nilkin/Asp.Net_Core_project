"use strict";

import { signalR } from "../lib/microsoft/signalr/dist/browser/signalr";


var connection = new signalR.HubConnectionBuilder().withUrl("/sidebar").build();

console.log(connection);