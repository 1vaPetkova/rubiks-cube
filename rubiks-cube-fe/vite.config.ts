import { defineConfig } from "vite";
import react from "@vitejs/plugin-react";
import tailwindcss from "@tailwindcss/vite";

// https://vite.dev/config/
export default defineConfig({
  server: {
    cors: {
      origin: "http://my-backend.example.com",
    },
  },
  plugins: [react(), tailwindcss()],
});
