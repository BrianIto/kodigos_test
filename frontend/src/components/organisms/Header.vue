<script lang="ts" setup>
import {
  BellIcon,
  ArrowRightStartOnRectangleIcon,
} from "@heroicons/vue/24/outline";
import IconButton from "../atoms/IconButton.vue";

</script>

<template>
  <div
    class="w-full shadow-xs shadow-cyan-200 h-16 px-4 items-center flex bg-white z-10 sticky top-0 "
  >
    <img
      src="https://www.kodigos.com.br/assets/logo2.c8b70bd7.png"
      alt="Kodigos Logo"
      class="h-full"
    />
    <div class="flex-1 flex items-center justify-end">
      <IconButton :icon="BellIcon" />
      <p class="px-5">Administrador</p>
      <IconButton :icon="ArrowRightStartOnRectangleIcon" />
    </div>
  </div>
</template>
