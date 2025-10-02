<script setup lang="ts">
import HelloWorld from './components/HelloWorld.vue';
</script>

<template>
  <main class="min-h-screen bg-slate-900 text-slate-100">
    <section class="mx-auto flex max-w-4xl flex-col gap-6 px-6 py-16 text-center">
      <h1 class="text-4xl font-bold tracking-tight sm:text-5xl">
        ¡Bienvenido a tu proyecto Vue 3 + TypeScript + Tailwind!
      </h1>
      <p class="text-lg text-slate-300">
        Personaliza esta plantilla para comenzar a construir tu aplicación.
      </p>
      <HelloWorld msg="Comienza a editar en src/components/HelloWorld.vue" />
    </section>
  </main>
</template>
