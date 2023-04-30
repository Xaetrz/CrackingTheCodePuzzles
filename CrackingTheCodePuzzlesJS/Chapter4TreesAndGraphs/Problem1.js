'use strict';

class Graph {
    vertices = []; // type Node[]
}

class Node {
    name = "";
    children = []; // type Node[]
    constructor(name) {
        this.name = name;
    }
}

/*
  Problem: 4.1 Route Between Nodes: Given a directed graph, design an algorithm to find out whether there is a route between nodes.
  Description: Uses breadth-first search to find existence of a route from node1 to node2.
*/
function existsRouteBetweenNodes(node1, node2) {
    if (node1 === node2) return true;

    let queue = [];
    let visited = new Map();
    queue.push(node1);
    visited[node1] = true;
    visited[node2] = true;
    
    while (queue.length > 0) {
        let nextNode = queue.shift();
        for (let adjNode of nextNode.children) {

                
            if (adjNode === node2) return true;
            
            if (visited[adjNode.name]) continue;  // Assumes nodes have unique names. Can't use objects as keys. Solution in book keeps track of state via Node object itself

            queue.push(adjNode);
            visited[adjNode.name] = true;         
        }
    }
    return false;
}

function testSimple() {
    let vertex1 = new Node("v1");
    let vertex2 = new Node("v2");
    let vertex3 = new Node("v3");
    let vertex4 = new Node("v4");
    let vertex5 = new Node("v5");
    let vertex6 = new Node("v6");

    vertex1.children.push(vertex2);
    vertex3.children.push(vertex1);
    vertex3.children.push(vertex4);
    vertex4.children.push(vertex3); // Cycle

    // Unconnected cycle
    vertex5.children.push(vertex6);
    vertex6.children.push(vertex5);
    
    console.assert(existsRouteBetweenNodes(vertex1, vertex2),"Test 1 Failed");
    console.assert(!existsRouteBetweenNodes(vertex1, vertex4),"Test 2 Failed");
    console.assert(existsRouteBetweenNodes(vertex4, vertex2),"Test 3 Failed");
    console.assert(!existsRouteBetweenNodes(vertex2, vertex4),"Test 4 Failed");
    console.assert(!existsRouteBetweenNodes(vertex5, vertex2),"Test 5 Failed");
}

testSimple();