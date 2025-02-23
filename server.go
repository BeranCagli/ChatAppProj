package main

import (
	"bufio"
	"fmt"
	"net"
	"sync"
)

var (
	clients = make(map[net.Conn]bool)
	mu      sync.Mutex
)

func handleClient(conn net.Conn) {
	defer conn.Close()
	reader := bufio.NewReader(conn)

	for {
		msg, err := reader.ReadString('\n')
		if err != nil {
			mu.Lock()
			delete(clients, conn)
			mu.Unlock()
			fmt.Println("Client disconnected:", conn.RemoteAddr())
			return
		}

		fmt.Printf("Received: %s", msg)

		mu.Lock()
		for client := range clients {
			if client != conn {
				_, _ = client.Write([]byte(msg))
			}
		}
		mu.Unlock()
	}
}

func main() {
	ln, err := net.Listen("tcp", ":8080")
	if err != nil {
		fmt.Println("Error starting server:", err)
		return
	}
	defer ln.Close()

	fmt.Println("TCP Server started on port 8080")

	for {
		conn, err := ln.Accept()
		if err != nil {
			fmt.Println("Error accepting connection:", err)
			continue
		}

		mu.Lock()
		clients[conn] = true
		mu.Unlock()

		fmt.Println("New client connected:", conn.RemoteAddr())
		go handleClient(conn)
	}
}
