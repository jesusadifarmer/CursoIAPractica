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
  <main class="flex min-h-screen items-center justify-center bg-slate-900 px-4 py-12 text-slate-100">
    <section class="w-full max-w-md rounded-2xl border border-slate-800 bg-slate-950/60 p-8 shadow-2xl shadow-slate-950/30 backdrop-blur">
      <header class="mb-8 text-center">
        <h1 class="text-3xl font-bold tracking-tight">Bienvenido</h1>
        <p class="mt-2 text-sm text-slate-400">Inicia sesión para continuar</p>
      </header>
      <form class="space-y-6" @submit.prevent="handleSubmit">
        <div class="space-y-2">
          <label class="block text-sm font-medium text-slate-300" for="username">Usuario</label>
          <input
            id="username"
            v-model="credentials.username"
            type="text"
            placeholder="Usuario"
            class="w-full rounded-lg border border-slate-700 bg-slate-900/80 px-4 py-3 text-sm text-slate-100 outline-none transition focus:border-indigo-500 focus:ring-2 focus:ring-indigo-400/40"
            required
          />
        </div>
        <div class="space-y-2">
          <label class="block text-sm font-medium text-slate-300" for="password">Contraseña</label>
          <input
            id="password"
            v-model="credentials.password"
            type="password"
            placeholder="*"
            class="w-full rounded-lg border border-slate-700 bg-slate-900/80 px-4 py-3 text-sm text-slate-100 outline-none transition focus:border-indigo-500 focus:ring-2 focus:ring-indigo-400/40"
            required
          />
        </div>
        <button
          type="submit"
          class="w-full rounded-lg bg-indigo-500 px-4 py-3 text-sm font-semibold text-white transition hover:bg-indigo-400 focus:outline-none focus:ring-2 focus:ring-indigo-300 focus:ring-offset-2 focus:ring-offset-slate-950"
        >
          Iniciar sesión
        </button>
      </form>
    </section>
  </main>
</template>
