'use strict';

/*
  Problem: 4.2 Minimal Tree: Given a sorted (increasing order) array with unique integer elements, write an algorithm to create a binary search tree with minimal height.
  Description: 
  Test Cases: Even [10 20 30 40], Odd [10 20 30 40 50]
*/
function createBalancedBinaryTree(sortArr) {
    return new BinaryTree(createBalancedBinaryTreeHelper(sortArr));
}

function createBalancedBinaryTreeHelper(binaryTree, sortArr) {
    if (sortArr.Length < 1) return new Node(null);
    else if (sortArr.Length === 1) return new Node()

    idxMid = Math.ceil(sortArr.Length / 2);
    valMid = sortArr[idxMid];
    left = createBalancedBinaryTreeHelper(binaryTree, sortArr.slice(0, idxMid + 1));
    right = createBalancedBinaryTreeHelper(binaryTree, sortArr.slice(idxMid + 1, sortArr.length));
    return new Node(valMid, left, right);
}


class BinaryTree {
    node = null;
    constructor(parent) {
        this.node = parent;
    }
}

class Node {
    value = null;
    left = null;
    right = null;
    constructor(val, left, right)
    {
        if (left === null || left instanceof Node) throw new Error("Invalid argument for left");
        if (right === null || right instanceof Node) throw new Error("Invalid argument for right");
        this.value = val;
        this.left = left;
        this.right = right;
    }
}
