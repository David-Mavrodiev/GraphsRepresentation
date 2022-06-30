# Install networkx module with 'pip install networkx'
import networkx as nx
import matplotlib.pyplot as plt

class Graph:   
    def __init__(self):       
        self.edges = []

    def addEdge(self, fromVertex, toVertex):
        edge = [fromVertex, toVertex]
        self.edges.append(edge)

    def display(self):
        graph = nx.Graph()
        graph.add_edges_from(self.edges)
        nx.draw_networkx(graph)
        plt.show()

graph = Graph()
graph.addEdge(1, 0);
graph.addEdge(0, 2);
graph.addEdge(2, 1);
graph.addEdge(0, 3);
graph.addEdge(1, 4);

graph.display()