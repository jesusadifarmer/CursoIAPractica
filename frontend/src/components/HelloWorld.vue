<script setup lang="ts">
interface Props {
  msg: string;
}

const props = defineProps<Props>();
</script>

<template>
  <div class="rounded-lg border border-slate-700 bg-slate-800 p-6 text-left shadow-lg">
    <h2 class="mb-2 text-2xl font-semibold text-slate-100">{{ props.msg }}</h2>
    <p class="text-slate-300">
      Edita <code class="font-mono text-slate-200">components/HelloWorld.vue</code> para comenzar.
    </p>
  </div>
</template>
