<script setup lang="ts">
import { reactive } from 'vue';

const credentials = reactive({
  username: '',
  password: '',
});

const handleSubmit = () => {
  // Aquí se puede manejar el proceso de autenticación.
  console.log('Intento de inicio de sesión', credentials);
};
</script>

<template>
  <main
    class="flex min-h-screen items-center justify-center bg-gradient-to-br from-[#0b3d2e] via-[#0f5c3b] to-[#1c8b45] px-4 py-12 text-[#0f3b2b]"
  >
    <section
      class="w-full max-w-md rounded-2xl border border-white/20 bg-white/95 p-8 text-[#0f3b2b] shadow-[0_25px_50px_-12px_rgba(15,92,59,0.45)] backdrop-blur"
    >
      <header class="mb-8 text-center">
        <h1 class="text-3xl font-bold tracking-tight text-[#0f5c3b]">Bienvenido</h1>
        <p class="mt-2 text-sm text-[#4c8064]">Inicia sesión para continuar</p>
      </header>
      <form class="space-y-6" @submit.prevent="handleSubmit">
        <div class="space-y-2">
          <label class="block text-sm font-medium text-[#1c6543]" for="username">Usuario</label>
          <input
            id="username"
            v-model="credentials.username"
            type="text"
            placeholder="Usuario"
            class="w-full rounded-lg border border-[#bcdcc6] bg-[#f2faf4] px-4 py-3 text-sm text-[#124331] outline-none transition focus:border-[#6dbd44] focus:ring-2 focus:ring-[#6dbd44]/40"
            required
          />
        </div>
        <div class="space-y-2">
          <label class="block text-sm font-medium text-[#1c6543]" for="password">Contraseña</label>
          <input
            id="password"
            v-model="credentials.password"
            type="password"
            placeholder="********"
            class="w-full rounded-lg border border-[#bcdcc6] bg-[#f2faf4] px-4 py-3 text-sm text-[#124331] outline-none transition focus:border-[#6dbd44] focus:ring-2 focus:ring-[#6dbd44]/40"
            required
          />
        </div>
        <button
          type="submit"
          class="w-full rounded-lg bg-[#6dbd44] px-4 py-3 text-sm font-semibold text-white transition hover:bg-[#5aa636] focus:outline-none focus:ring-2 focus:ring-[#5aa636] focus:ring-offset-2 focus:ring-offset-white"
        >
          Iniciar sesión
        </button>
      </form>
    </section>
  </main>
</template>
